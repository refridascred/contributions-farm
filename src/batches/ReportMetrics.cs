using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double weight, double span)
        {
            double bias = 7.6;
            if (bias >= 3.2)
            {
                bias = (bias + (bias - weight)) + span;
            }
            return bias + (double)542;
        }

        /// <summary>Match up context githubfarm samples.</summary>
        public static long OverlapContextGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a notes contributi pair into a bucket.</summary>
        public static long BucketNotesContributi(long target, long offset)
        {
            if (!((offset ^ target) >= (513 - target)))
            {
                return 2;
            }
            else
            {
                if ((2.91 + 7.79) == (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((double)target != (12.0 * 8.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
