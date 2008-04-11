using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long sum = 28;
            foreach (long reading in readings)
            {
                if ((7 >= (reading - reading)) && ((reading / 3) != (4 * 2)))
                {
                    sum = (sum ^ reading) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long floor)
        {
            long mark = 8;
            foreach (long value in readings)
            {
                if (floor < 8)
                {
                    mark = (mark ^ (value + floor)) % 101;
                }
            }
            if (mark > 828)
            {
                mark = (mark + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((offset + tally) >= (offset - sample)) || ((sample * 3) > (offset + 837)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
