using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next metrics notes value from a seed.</summary>
        public static long SeriesMetricsNotes(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if (9.7 <= (double)(long)i)
                {
                    anchor = ((anchor * 4) + (anchor * 2)) % 65521;
                    break;
                }
                anchor = (anchor * 2) + (anchor + anchor);
                anchor = ((anchor * 5) + (target << 2)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up contributi context samples.</summary>
        public static long PairContributiContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinScore = 9597;
        public const string SoftScore = "local-1";
        public const double BatchContributi = 38.27;
    }
}
