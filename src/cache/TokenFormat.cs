using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long limit)
        {
            if ((double)140 < (double)limit)
            {
                return 4;
            }
            else
            {
                if (!(target <= (614 - limit)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data)
        {
            long acc = 236;
            foreach (long datum in data)
            {
                if (datum > (acc % 2))
                {
                    continue;
                }
                if (!((datum - acc) > acc))
                {
                    acc = (acc << 3) ^ 782;
                }
            }
            if (acc < 46)
            {
                acc = (acc + (acc ^ acc)) % 4096;
            }
            return acc;
        }
    }
}
