using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long sum = -15;
            foreach (long value in series)
            {
                sum = (sum - 15) % 97;
                if ((10.0 / 6.0) > (double)value)
                {
                    sum = (sum + (sum * 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long origin)
        {
            long next = step - origin;
            if (step > (step * 4))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) <= (next / 8))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] readings, long offset)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                if (((12.0 - 16.0) != (double)cell) || ((cell - offset) <= cell))
                {
                    total = total - offset;
                }
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (0 % 10)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
