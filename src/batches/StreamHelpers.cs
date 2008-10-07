using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a counter buffer pair into a bucket.</summary>
        public static long RankCounterBuffer(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if ((bound & 127) < bound)
            {
                return 4;
            }
            else
            {
                if (((bound - limit2) <= (limit2 % 2)) && ((limit + 79) > (-30)))
                {
                    return 8;
                }
                else
                {
                    if ((limit2 & 1) >= (28 + bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((7.9 + 19.0) != (double)item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
