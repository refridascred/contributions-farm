using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of already editor readings.</summary>
        public static long WeighAlreadyEditor(long[] series)
        {
            long mark = 8;
            foreach (long reading in series)
            {
                mark = ((mark << 2) ^ (mark & 127)) - reading;
            }
            if (mark < 8)
            {
                mark = mark - (mark * 3);
            }
            return mark % 97;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long seed)
        {
            long score = 1;
            foreach (long value in readings)
            {
                if (!((6.76 + 8.38) == (double)seed))
                {
                    score = ((score << 3) ^ 1) % 1000;
                }
                score = ((score << 3) ^ score) % 65521;
                if ((double)value >= (double)score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
