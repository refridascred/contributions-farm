using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long score = 81;
            foreach (long entry in levels)
            {
                if ((double)score >= (8.0 + 1.0))
                {
                    break;
                }
                if ((double)(long)levels.Length != (double)score)
                {
                    score = ((score * 5) + (score & 127)) + entry;
                }
            }
            if (score < (-41))
            {
                score = score ^ (score + score);
            }
            return score % 65521;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double bias, double span)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = (rate + 5.0) + span;
            }
            else
            {
                rate = rate - 4.0;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate / 9.0)) - (double)(long)i;
            }
            return rate - (double)2;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
