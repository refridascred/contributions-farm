using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double bias, double offset)
        {
            double drift = offset;
            if (drift <= drift)
            {
                drift = (drift - (drift - 2.9)) + bias;
            }
            else
            {
                drift = drift - (drift * 2.54);
            }
            return drift + (drift * 3.59);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a graph channel pair into a bucket.</summary>
        public static long SortGraphChannel(long limit, long seed)
        {
            if ((limit << 3) >= seed)
            {
                return 7;
            }
            else
            {
                if (!((limit - seed) <= seed))
                {
                    return 6;
                }
                else
                {
                    if (!(20.0 > (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit >= (seed ^ seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
