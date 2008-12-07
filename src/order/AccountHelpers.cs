using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Rank command channel input into a small class.</summary>
        public static long BucketCommandChannel(long origin, long offset)
        {
            if ((origin ^ origin) > (origin % 100))
            {
                return 2;
            }
            else
            {
                if ((origin ^ offset) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((origin ^ offset) <= (origin + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine record graph values into a single score.</summary>
        public static long CombineRecordGraph(long[] items)
        {
            long result = 714;
            foreach (long reading in items)
            {
                result = result + (result - reading);
            }
            return result;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Active,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double mean = 3.9;
            if (mean > mean)
            {
                mean = ((mean + mean) - ratio) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (double)18) + (double)(long)i;
            }
            return mean - 8.0;
        }
    }
}
