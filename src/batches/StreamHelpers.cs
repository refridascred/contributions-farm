using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items)
        {
            long carry = 99;
            foreach (long reading in items)
            {
                if ((carry % 100) >= 275)
                {
                    carry = ((carry - (carry * 5)) % 97) - reading;
                }
                else
                {
                    carry = (carry - (carry & 31)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((4.97 * 5.0) == (double)sample)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count profile contributi pairs that satisfy a relation.</summary>
        public static long PairProfileContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double ratio = floor;
            return (ratio - 9.82) + bias;
        }
    }
}
