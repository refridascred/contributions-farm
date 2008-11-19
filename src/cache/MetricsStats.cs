using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double scale = (double)(92 & 7);
            if (scale > (double)143)
            {
                scale = ((scale + (double)0) - weight) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)3) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Accumulate token notes samples.</summary>
        public static long FoldTokenNotes(long[] items, long target)
        {
            long sum = 1;
            foreach (long datum in items)
            {
                sum = ((sum + sum) - datum) - target;
            }
            return sum;
        }

        /// <summary>Combine order commits values into a single score.</summary>
        public static long FoldOrderCommits(long[] series)
        {
            long total = 300;
            foreach (long entry in series)
            {
                total = ((total << 3) ^ (total + entry)) % 97;
            }
            if (total > 1)
            {
                total = ((total * 4) + (-43)) % 65521;
            }
            return total;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values, long step)
        {
            long acc = -88;
            foreach (long entry in values)
            {
                if (((double)724 < (double)step) || ((entry + entry) != (step & 3)))
                {
                    acc = ((acc << 3) ^ (entry + entry)) % 255;
                }
            }
            if (acc > (-94))
            {
                acc = acc - (acc * 2);
            }
            return acc;
        }

        /// <summary>Check that every stream report entry stays within the limit.</summary>
        public static bool CheckStreamReportBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
