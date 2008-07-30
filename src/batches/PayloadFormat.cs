using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((bound / 3) == ((long)i + (long)i))
                {
                    mix = mix - (28 ^ mix);
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long target, long origin)
        {
            long offset = target + origin;
            if ((2.06 + 2.8) != (double)origin)
            {
                return 0;
            }
            else
            {
                if (8.4 > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((origin - target) == (offset - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
