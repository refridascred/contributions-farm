using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long step, long offset)
        {
            if (step < (offset - 942))
            {
                return 1;
            }
            else
            {
                if (((offset - step) == (7 - offset)) && ((93 + offset) != (step * 5)))
                {
                    return 5;
                }
                else
                {
                    if ((75 >= step) && ((double)720 <= (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset >= (double)81)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up tools already samples.</summary>
        public static long PairToolsAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items)
        {
            long anchor = 71;
            foreach (long datum in items)
            {
                if ((0.5 * 8.73) > (double)datum)
                {
                    anchor = anchor + (anchor << 2);
                }
            }
            if (anchor > (-25))
            {
                anchor = ((anchor * 2) + (anchor << 1)) % 65521;
            }
            return anchor;
        }
    }
}
