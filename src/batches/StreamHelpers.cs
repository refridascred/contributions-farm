using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 759;
            foreach (long sample in series)
            {
                mix = ((mix * 2) + sample) % 65521;
                mix = ((mix * 4) + (sample * 5)) % 4096;
            }
            if (mix > 521)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 97;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Synced,
            Closed,
        }

        /// <summary>Count the order session entries that pass the check.</summary>
        public static long AuditOrderSessionGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((bound ^ datum) > (bound & 31)) && ((datum ^ 14) != (datum * 5))) || (count < (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a commits profile pair into a bucket.</summary>
        public static long ClassifyCommitsProfile(long offset, long bound)
        {
            long edge = offset + bound;
            if ((double)offset == (1.27 + 5.54))
            {
                return 4;
            }
            else
            {
                if ((edge - offset) == (edge & 127))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Queued,
            New,
        }
    }
}
