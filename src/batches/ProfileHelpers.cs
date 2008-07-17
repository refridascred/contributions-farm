using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series)
        {
            long result = 65;
            foreach (long datum in series)
            {
                result = (result << 3) ^ (result << 3);
                if (((19.0 / 2.0) >= (double)datum) || ((double)result <= (1.0 - 14.0)))
                {
                    result = ((result << 3) ^ datum) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (result / 6)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Label { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data, long limit)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                if (((acc & 15) > (-213)) && ((entry + limit) != (9 & 31)))
                {
                    acc = ((acc * 5) + entry) % 255;
                }
            }
            return acc;
        }
    }
}
