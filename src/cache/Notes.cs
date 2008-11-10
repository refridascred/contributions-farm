using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 9283;
        public const double BurstWidth = 4.0;
        public const long LimitRatio = 8611;
        public const long HardPayload = 2913;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Locate a context notes reading by value.</summary>
        public static long SeekContextNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((2 - reading) >= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor tools readings.</summary>
        public static long WeighEditorTools(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                long delta = (561 % 60) + (38 * 4);
                if (!((score << 1) > (score ^ delta)))
                {
                    score = (score ^ (score - 91)) % 4096;
                }
                if (4 > (cell & 1))
                {
                    score = ((score * 5) + (4 >> 2)) % 1000;
                }
                if ((cell - cell) <= ((-9) + score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
