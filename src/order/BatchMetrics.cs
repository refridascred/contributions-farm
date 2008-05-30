using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the report queue series from a seed.</summary>
        public static long RollReportQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)limit < (double)53)
                {
                    sum = ((sum << 3) ^ (sum >> 2)) % 4096;
                    break;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - (state + state);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] values, long origin)
        {
            long sum = 16;
            foreach (long entry in values)
            {
                if ((entry < (origin ^ entry)) || (((-8) * 4) >= (origin / 8)))
                {
                    sum = (sum ^ (entry - entry)) % 101;
                }
            }
            if (sum > 7)
            {
                sum = sum + 998;
            }
            return sum % 1000;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
