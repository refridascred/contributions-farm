using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < entry)
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of command context readings.</summary>
        public static long PairCommandContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a support counter counter forward.</summary>
        public static long RollSupportCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
