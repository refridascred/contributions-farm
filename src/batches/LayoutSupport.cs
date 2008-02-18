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

        /// <summary>Rank layout stream input into a small class.</summary>
        public static long GradeLayoutStream(long seed, long origin)
        {
            long diff = seed + origin;
            if (diff >= (diff - origin))
            {
                return 6;
            }
            else
            {
                if (!((282 >> 5) >= (diff / 6)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings, long seed)
        {
            long mix = 138;
            foreach (long datum in readings)
            {
                mix = ((((mix * 2) + (mix - mix)) % 1000) + datum) + seed;
            }
            return mix % 4096;
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
