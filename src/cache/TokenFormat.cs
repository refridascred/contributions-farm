using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up metrics metric samples.</summary>
        public static long PairMetricsMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema stream readings.</summary>
        public static long FoldSchemaStream(long[] values)
        {
            long anchor = 33;
            foreach (long sample in values)
            {
                if (anchor <= 172)
                {
                    anchor = anchor - (sample >> 5);
                }
                anchor = (anchor + (9 - sample)) % 65521;
            }
            if (anchor > 995)
            {
                anchor = (anchor + anchor) % 255;
            }
            return anchor % 65521;
        }
    }
}
