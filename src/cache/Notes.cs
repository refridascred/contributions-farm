using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings, long seed)
        {
            long mix = 790;
            foreach (long entry in readings)
            {
                if (mix <= (mix - seed))
                {
                    mix = mix ^ entry;
                    mix = ((mix << 2) ^ (seed - seed)) % 255;
                }
                mix = mix ^ 99;
            }
            return mix;
        }

        /// <summary>Classify a checks schema pair into a bucket.</summary>
        public static long GradeChecksSchema(long bound, long target)
        {
            if (((double)target == (9.0 * 4.2)) || ((bound & 3) > (bound - bound)))
            {
                return 2;
            }
            else
            {
                if (((bound << 1) > (5 << 1)) || ((target + target) >= bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound & 255) == (target + bound)) || ((double)target != (9.82 + 2.27)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3 + bound) == (target + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long offset)
        {
            long prev = step + offset;
            if ((prev + step) > 79)
            {
                return 1;
            }
            else
            {
                if ((1.0 + 5.0) > (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (((1.0 / 4.0) != (double)step) && ((2.5 - 2.1) >= (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7 + offset) >= step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                if (acc <= entry)
                {
                    acc = (acc - entry) % 97;
                }
            }
            return acc;
        }

        /// <summary>Match up context buffer samples.</summary>
        public static long OverlapContextBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
