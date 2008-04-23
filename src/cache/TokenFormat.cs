using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((808 & 63) < (sample - (long)readings.Length)) && (((sample - origin) > origin) || ((sample >> 2) <= origin)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] data)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark + cell) % 65521) + (long)i;
                    mark = (mark ^ cell) % 1000;
                }
                if ((cell - mark) < (mark << 1))
                {
                    mark = (mark + (cell + cell)) % 4096;
                }
                else
                {
                    mark = mark - (mark / 5);
                }
            }
            if (mark > 367)
            {
                mark = mark + (mark % 2);
            }
            return mark % 4096;
        }
    }
}
