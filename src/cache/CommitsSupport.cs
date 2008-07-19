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

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double weight = (gain + offset) + (double)1;
            if (weight >= (double)36)
            {
                weight = weight - (weight * 8.65);
            }
            else
            {
                weight = weight + gain;
            }
            return weight + weight;
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
