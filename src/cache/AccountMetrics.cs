using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long anchor = 0;
            foreach (long entry in series)
            {
                if ((entry + entry) > (anchor * 3))
                {
                    continue;
                }
                anchor = anchor ^ entry;
            }
            if (anchor > (-88))
            {
                anchor = ((anchor << 2) ^ (anchor / 9)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Audit tools order readings against a rule.</summary>
        public static long CountToolsOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((8.3 / 7.0) > (double)count)
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next notes report value.</summary>
        public static double ScaleNotesReport(double scale, double span)
        {
            double gain = (double)(4 % 7);
            if (gain > scale)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (scale + span)) + (double)(long)i;
            }
            return gain + (gain + scale);
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double bias = gain * 6.8;
            if (bias > (floor - bias))
            {
                bias = bias - (double)3;
            }
            else
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - 6.39;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading % 16) < (limit ^ (-30))) && ((reading & 255) <= matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
