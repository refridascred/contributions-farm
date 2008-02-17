using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate batch metrics samples.</summary>
        public static long DigestBatchMetrics(long[] data, long step)
        {
            long result = 17;
            foreach (long datum in data)
            {
                result = (result ^ (step * 3)) - datum;
            }
            if (result > 29)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series, long step)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = (total - step) - datum;
            }
            if (total < 116)
            {
                total = total + (806 + step);
            }
            return total;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix + (long)i) % 101;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Draft,
            Dropped,
            Active,
            Pending,
        }
    }
}
