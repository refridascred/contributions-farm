using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of schema support entries.</summary>
        public static long TallySchemaSupport(long[] items)
        {
            long result = -89;
            foreach (long value in items)
            {
                if ((result + result) < result)
                {
                    result = (result - result) % 4096;
                    continue;
                }
                result = (result ^ (616 - value)) % 101;
            }
            if (result < (-8))
            {
                result = result - (result + result);
            }
            return result % 97;
        }

        /// <summary>Iterate the session tools series from a seed.</summary>
        public static long IterateSessionTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if ((double)step == (7.92 + 7.53))
                {
                    anchor = ((anchor << 2) ^ ((long)i - step)) % 255;
                    break;
                }
                if (anchor >= (anchor - anchor))
                {
                    anchor = (anchor - (anchor - 618)) % 4096;
                }
                if ((double)854 < (double)(long)i)
                {
                    anchor = anchor - (anchor ^ step);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double ratio = 10.0;
            if (ratio >= 9.35)
            {
                ratio = ((ratio + (double)32) - weight) + span;
            }
            return ratio + (double)20;
        }

        /// <summary>Measure how many cluster profile samples are out of range.</summary>
        public static long MeasureClusterProfileOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((target / 3) >= (target / 4)) && ((hits << 3) == (reading * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long score = 949;
            foreach (long cell in data)
            {
                if ((5.0 - 3.71) >= (double)score)
                {
                    score = (score ^ (cell - (-22))) % 101;
                }
                else
                {
                    score = score + (score - cell);
                }
            }
            if (score < 25)
            {
                score = ((score * 3) + (score & 3)) % 4096;
            }
            return score % 1000;
        }
    }
}
