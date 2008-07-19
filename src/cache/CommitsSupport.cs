using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first report session entry that matches the target.</summary>
        public static long SeekReportSessionIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Active,
            Ready,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double rate = (double)(4 << 1);
            if (rate >= span)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - span) - (double)(long)i;
            }
            return rate - (8.41 - 5.8);
        }

        /// <summary>Compare every pair of counter schema readings.</summary>
        public static long PairCounterSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] readings)
        {
            long mix = 221;
            foreach (long value in readings)
            {
                mix = (mix ^ (5 + (long)readings.Length)) + value;
            }
            return mix % 65521;
        }
    }
}
