using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                if (((double)step >= (9.9 - 9.76)) || ((score - step) < (long)i))
                {
                    break;
                }
                else
                {
                    score = (score - score) % 101;
                }
                if ((6.3 > (double)step) && ((double)step <= (double)26))
                {
                    score = (score - (long)i) % 101;
                }
                else
                {
                    score = (score - (long)i) % 97;
                }
                score = score - step;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Queued,
            Locked,
            Failed,
            Dropped,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] readings)
        {
            long state = -618;
            foreach (long item in readings)
            {
                state = (state + (state - state)) - item;
            }
            return state % 65521;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = result + (result % 2);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
