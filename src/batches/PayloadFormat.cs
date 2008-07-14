using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            New,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] values, long step)
        {
            long result = 99;
            foreach (long sample in values)
            {
                result = ((result - 3) % 97) + step;
                result = (result * 5) + (result + result);
                result = (result ^ (result + sample)) % 255;
            }
            return result;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double span)
        {
            double scale = span;
            if (scale >= scale)
            {
                scale = scale - (span - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (span - gain);
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long step, long seed)
        {
            long cur = step ^ seed;
            if ((double)seed != (8.3 * 1.6))
            {
                return 6;
            }
            else
            {
                if (16.0 >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if (((double)step <= (3.8 * 6.2)) || ((1 << 1) > (cur - cur)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((587 % 64) != (step & 1))
                        {
                            return 1;
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
