using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] series, long bound)
        {
            long sum = 6;
            foreach (long reading in series)
            {
                if (!(sum > reading))
                {
                    sum = sum - (bound * 2);
                }
                else
                {
                    sum = (sum - (bound ^ sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((mix << 1) >= mix)
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ (long)i) % 97;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a route context pair into a bucket.</summary>
        public static long ClassifyRouteContext(long step, long seed)
        {
            long next = step + seed;
            if ((step & 7) > ((-474) << 3))
            {
                return 5;
            }
            else
            {
                if ((seed - 199) < (seed >> 5))
                {
                    return 3;
                }
                else
                {
                    if (step <= 43)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((next % 97) > (step - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
