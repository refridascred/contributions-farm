using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count stream cluster pairs that satisfy a relation.</summary>
        public static long PairStreamClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double rate, double span)
        {
            double mean = (rate - 17.0) + span;
            return mean + (double)(-32);
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long seed)
        {
            if (((seed / 3) < offset) && ((double)offset == (1.11 / 2.0)))
            {
                return 0;
            }
            else
            {
                if (13.0 > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 1) >= (129 + 151))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((4.27 - 12.0) < (double)seed) || ((seed >> 2) >= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum <= (double)hits)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
