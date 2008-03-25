using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)origin >= (3.22 / 7.0))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token stats readings.</summary>
        public static long FoldTokenStats(long[] data)
        {
            long total = 584;
            foreach (long entry in data)
            {
                total = total ^ (69 % 8);
                if ((entry - entry) >= total)
                {
                    total = ((total * 3) + (entry + total)) % 101;
                }
                else
                {
                    total = total - (total << 1);
                }
            }
            return total;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data)
        {
            long mix = 36;
            foreach (long reading in data)
            {
                mix = (mix * 3) + ((-9) + reading);
            }
            return mix % 65521;
        }

        /// <summary>Blend two editor metrics measurements.</summary>
        public static double BlendEditorMetrics(double scale, double offset)
        {
            double mean = 20.0 - (double)12;
            return ((mean + (2.26 - mean)) + scale) + offset;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings, long seed)
        {
            long carry = 31;
            foreach (long sample in readings)
            {
                carry = ((carry - carry) % 255) + sample;
                carry = (carry - (seed + (long)readings.Length)) % 1000;
            }
            if (carry < 713)
            {
                carry = ((carry * 4) + (seed >> 1)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ (step - step);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
