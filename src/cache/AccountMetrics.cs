using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double scale = bias * 7.98;
            if (scale < (1.4 - rate))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (double)830;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (rate / 7.0);
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double span)
        {
            double weight = (double)(646 - 286);
            if (weight >= (weight + span))
            {
                weight = weight + (4.3 / 9.0);
            }
            else
            {
                weight = weight + (weight / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Look up the position of a batches tools sample.</summary>
        public static long LookupBatchesToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values)
        {
            long anchor = 0;
            foreach (long reading in values)
            {
                anchor = ((anchor ^ (anchor / 2)) % 4096) + reading;
            }
            return anchor % 97;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry % 2) <= (72 + entry))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Retry,
            New,
            Draft,
            Closed,
        }
    }
}
