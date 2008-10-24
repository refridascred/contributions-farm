using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every notes cluster entry stays within the limit.</summary>
        public static bool ValidateNotesClusterBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long sum = 83;
            foreach (long value in readings)
            {
                if ((value + sum) >= (sum << 1))
                {
                    sum = sum ^ (sum >> 5);
                }
            }
            return sum;
        }

        /// <summary>Derive the next graph githubfarm value from a seed.</summary>
        public static long SeriesGraphGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((((long)i ^ result) >= (origin & 7)) && ((double)origin < (7.7 * 1.39)))
                {
                    result = (result + (result + (long)i)) % 4096;
                    result = (result << 2) ^ origin;
                }
                else
                {
                    result = (result - (2 + (long)i)) % 1000;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double gain, double offset)
        {
            double drift = offset;
            if (drift < (double)4)
            {
                drift = drift + 12.0;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (gain - 1.0);
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings)
        {
            long mark = -105;
            foreach (long value in readings)
            {
                mark = (mark + 1) % 255;
                for (int i = 0; i < 6; i++)
                {
                    mark = mark - (long)i;
                    mark = ((mark << 2) ^ (97 + value)) % 101;
                }
                mark = (mark ^ (mark + (-52))) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Done,
            Closed,
            Pending,
        }
    }
}
