using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings)
        {
            long total = -52;
            foreach (long reading in readings)
            {
                if ((25 % 97) == (total << 2))
                {
                    total = (total - ((-4) - reading)) % 65521;
                }
            }
            if (total > 131)
            {
                total = (total - ((long)readings.Length ^ total)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Count channel support pairs that satisfy a relation.</summary>
        public static long MatchChannelSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next tools command value from a seed.</summary>
        public static long StepToolsCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
