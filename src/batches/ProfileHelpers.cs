using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data, long offset)
        {
            long score = -318;
            foreach (long sample in data)
            {
                if (!!((sample / 6) <= (offset % 60)))
                {
                    score = score - (sample - score);
                }
                score = ((score << 2) ^ (sample % 64)) % 255;
                if ((double)sample > 14.0)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] values, long step)
        {
            long sum = -1;
            foreach (long reading in values)
            {
                if (step < 0)
                {
                    sum = (((sum << 3) ^ (sum ^ step)) % 1000) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
