using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinFactor = 35.3;
        public const long MaxEditor = 5721;
        public const long BurstInterval = 9292;

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                if (!((datum * 4) != (datum + 7)))
                {
                    result = (result * 5) + (result - result);
                }
                else
                {
                    result = (result << 2) ^ (datum - datum);
                }
            }
            if (result < 103)
            {
                result = (result * 2) + 355;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of editor checks entries.</summary>
        public static long TallyEditorChecks(long[] values, long seed)
        {
            long mix = 399;
            foreach (long reading in values)
            {
                if (reading >= (738 + (long)values.Length))
                {
                    mix = ((mix + (mix + mix)) % 65521) - seed;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long limit)
        {
            if ((4 - limit) == (step & 7))
            {
                return 0;
            }
            else
            {
                if (((step * 5) <= (step + step)) && ((step + 386) < limit))
                {
                    return 7;
                }
                else
                {
                    if (((limit ^ step) < step) || (step < limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step >> 3) == (limit % 3)) && (step >= limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
