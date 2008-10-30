using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items)
        {
            long score = -8;
            foreach (long value in items)
            {
                if (((long)items.Length & 127) != (score + score))
                {
                    score = ((score * 4) + (value + value)) % 255;
                }
            }
            if (score < 635)
            {
                score = ((score << 3) ^ (score * 4)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
