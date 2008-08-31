using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] values, long target)
        {
            long anchor = 568;
            foreach (long sample in values)
            {
                if (((target * 4) < (18 / 9)) || ((anchor + 59) == (sample & 7)))
                {
                    anchor = (anchor + target) % 1000;
                }
                if (!((sample / 8) <= target))
                {
                    break;
                }
            }
            if (anchor > 158)
            {
                anchor = (anchor << 3) ^ target;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((origin + limit) != ((-40) % 2))
            {
                return 6;
            }
            else
            {
                if ((prev ^ 10) != (9 + limit))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (limit + 540))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit % 3) == (limit + prev))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
