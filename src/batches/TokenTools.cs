using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values, long origin)
        {
            long total = -3;
            foreach (long item in values)
            {
                total = (total + (item - 698)) - origin;
            }
            return total % 1000;
        }

        /// <summary>Measure how many payload schema samples are out of range.</summary>
        public static long MeasurePayloadSchemaGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (21 > origin)
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
