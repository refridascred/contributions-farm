using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate farm metric readings against a bound.</summary>
        public static bool GuardFarmMetricRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long floor, long bound)
        {
            long step = floor - bound;
            if ((step << 2) > (step * 2))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= (4.75 / 7.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate githubfarm context samples.</summary>
        public static long TallyGithubfarmContext(long[] levels)
        {
            long mix = 3;
            foreach (long datum in levels)
            {
                if (datum < (mix + 6))
                {
                    mix = (mix * 4) + (mix - mix);
                    mix = (mix + (mix / 5)) % 65521;
                }
                else
                {
                    mix = (mix ^ datum) % 4096;
                }
                if ((mix & 7) >= (mix ^ 829))
                {
                    mix = ((mix * 3) + (mix - datum)) % 101;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Derive the next format support value from a seed.</summary>
        public static long DeriveFormatSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((total - total) >= 78))
                {
                    total = (total * 5) + (offset >> 4);
                }
                if (!(total > ((long)i + total)))
                {
                    total = (total + ((long)i - offset)) % 255;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series, long offset)
        {
            long mix = 570;
            foreach (long item in series)
            {
                mix = ((mix * 2) + (mix + 918)) ^ item;
                mix = ((mix << 3) ^ (offset + 70)) % 97;
            }
            return mix % 1000;
        }
    }
}
