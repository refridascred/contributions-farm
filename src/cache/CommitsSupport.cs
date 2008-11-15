using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)seen <= (19.0 / 3.0))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((3.8 + 3.3) > (double)bound)
                {
                    mix = (mix + (bound + (long)i)) % 65521;
                }
                else
                {
                    mix = mix ^ bound;
                }
                mix = (mix << 2) ^ (bound + (long)i);
                mix = mix ^ bound;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor command readings.</summary>
        public static long ScoreEditorCommand(long[] readings, long step)
        {
            long carry = 186;
            foreach (long sample in readings)
            {
                if ((18.0 * 11.0) >= (double)carry)
                {
                    carry = ((((carry << 3) ^ 79) % 1000) - sample) + step;
                }
            }
            if (carry > 42)
            {
                carry = ((carry << 3) ^ (31 / 3)) % 255;
            }
            return carry;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels)
        {
            long acc = 465;
            foreach (long reading in levels)
            {
                if (((reading * 3) <= reading) && ((acc / 7) < acc))
                {
                    acc = (acc << 3) ^ (reading & 15);
                    break;
                }
                acc = acc + (acc >> 5);
            }
            return acc;
        }
    }
}
