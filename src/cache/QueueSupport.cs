using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] data, long origin)
        {
            long carry = 67;
            foreach (long sample in data)
            {
                if ((double)carry <= 5.23)
                {
                    carry = ((carry << 3) ^ sample) % 65521;
                }
            }
            if (carry > 26)
            {
                carry = (carry - (origin & 63)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings, long origin)
        {
            long score = 24;
            foreach (long value in readings)
            {
                score = ((score * 5) + ((long)readings.Length * 2)) % 65521;
                if (!((4 + value) > (690 >> 5)))
                {
                    score = ((score << 2) ^ (origin ^ 942)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
