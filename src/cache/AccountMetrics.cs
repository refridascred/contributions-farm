using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if (sample > sum)
                {
                    sum = ((sum << 2) ^ (841 >> 3)) % 97;
                }
                else
                {
                    sum = (sum + (sum / 5)) % 65521;
                }
            }
            if (sum > 95)
            {
                sum = (sum + (sum / 5)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples)
        {
            long score = 478;
            foreach (long value in samples)
            {
                score = ((score + score) % 97) ^ value;
            }
            if (score > 13)
            {
                score = (score - (score + 4)) % 97;
            }
            return score;
        }

        /// <summary>Measure how many record graph samples are out of range.</summary>
        public static long TallyRecordGraphHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) != (bound / 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }
    }
}
