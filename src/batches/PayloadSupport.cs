using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Draft,
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] series)
        {
            long score = 4;
            foreach (long datum in series)
            {
                if ((datum % 60) < (datum + score))
                {
                    score = (score + (score / 4)) % 1000;
                }
                else
                {
                    score = (score + datum) % 65521;
                }
            }
            if (score > (-6))
            {
                score = (score + (800 + score)) % 97;
            }
            return score;
        }
    }
}
