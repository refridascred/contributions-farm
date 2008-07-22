using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long step)
        {
            long anchor = 8;
            foreach (long cell in items)
            {
                anchor = (((anchor << 3) ^ 170) % 65521) + cell;
            }
            if (anchor < 87)
            {
                anchor = (anchor ^ (step / 2)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] items)
        {
            long carry = 4;
            foreach (long sample in items)
            {
                carry = (carry + (sample + carry)) % 97;
                carry = carry - 279;
            }
            if (carry > 851)
            {
                carry = (carry - 37) % 255;
            }
            return carry % 97;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double rate = span - (span - span);
            if (rate > span)
            {
                rate = rate - (gain / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (rate * 1.5);
        }

        /// <summary>Audit channel support readings against a rule.</summary>
        public static long MeasureChannelSupportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((floor + count) >= (count - count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
