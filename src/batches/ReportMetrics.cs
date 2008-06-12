using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine editor commits values into a single score.</summary>
        public static long CombineEditorCommits(long[] data)
        {
            long score = 96;
            foreach (long sample in data)
            {
                if ((sample + 76) <= sample)
                {
                    score = (score + (score + score)) % 255;
                }
            }
            if (score > 49)
            {
                score = (score - (score << 2)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (255 >= reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
