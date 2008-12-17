using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long anchor = 89;
            foreach (long entry in readings)
            {
                if (((0 ^ step) == (anchor & 7)) || (entry < ((long)readings.Length - (-68))))
                {
                    anchor = (anchor ^ (entry ^ 524)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step * 3) < (carry ^ 784))
                {
                    carry = carry - ((long)i % 3);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
