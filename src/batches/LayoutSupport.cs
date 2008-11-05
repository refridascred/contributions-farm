using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate githubfarm schema readings against a bound.</summary>
        public static bool CheckGithubfarmSchemaBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stream record values into a single score.</summary>
        public static long ScoreStreamRecord(long[] values, long bound)
        {
            long mark = 64;
            foreach (long datum in values)
            {
                mark = ((mark << 2) ^ bound) ^ datum;
            }
            if (mark < (-57))
            {
                mark = mark - (mark + bound);
            }
            return mark;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items, long floor)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if (cell < (21 + floor))
                {
                    sum = sum ^ (cell + floor);
                }
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data)
        {
            long mix = 50;
            foreach (long datum in data)
            {
                long hits = (datum - datum) - 8;
                if (!!((hits & 63) <= (datum & 31)))
                {
                    mix = mix + mix;
                }
                if (((double)datum <= (double)mix) || ((datum + datum) < (datum + mix)))
                {
                    mix = (mix << 3) ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] items, long seed)
        {
            long mix = -89;
            foreach (long entry in items)
            {
                if ((mix >= (entry * 4)) && ((3.4 * 1.0) >= (7.07 / 7.0)))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = ((mix * 3) + seed) % 101;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 3) + (seed >> 1)) % 97;
            }
            return mix;
        }
    }
}
