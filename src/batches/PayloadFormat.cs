using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Failed,
            Paused,
            Synced,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples, long offset)
        {
            long score = 41;
            foreach (long reading in samples)
            {
                score = ((score << 3) ^ (offset >> 3)) % 97;
                if ((36 < reading) && ((double)reading == (double)(long)samples.Length))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = (score << 2) ^ (offset - offset);
                }
                if (!(660 <= (long)samples.Length))
                {
                    break;
                }
            }
            if (score < 46)
            {
                score = (score << 3) ^ (offset ^ offset);
            }
            return score;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] series, long limit)
        {
            long total = 92;
            foreach (long value in series)
            {
                if ((double)value == (8.37 - 8.1))
                {
                    total = ((total * 3) + (limit & 3)) % 1000;
                    break;
                }
                total = total - (value - value);
            }
            return total;
        }
    }
}
