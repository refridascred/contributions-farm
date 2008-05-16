using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a session cache pair into a bucket.</summary>
        public static long ClassifySessionCache(long origin, long seed)
        {
            if (seed > ((-3) * 2))
            {
                return 8;
            }
            else
            {
                if ((seed - origin) < (seed + origin))
                {
                    return 7;
                }
                else
                {
                    if (!(seed >= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.9 - 1.3) > (3.9 + 5.32))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double rate = gain;
            if (rate >= rate)
            {
                rate = rate + (rate - span);
            }
            else
            {
                rate = rate + (double)95;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (gain - gain)) + (double)(long)i;
            }
            return rate + (7.2 * 9.21);
        }
    }
}
