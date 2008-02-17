using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate batch metrics samples.</summary>
        public static long DigestBatchMetrics(long[] data, long step)
        {
            long result = 17;
            foreach (long datum in data)
            {
                result = (result ^ (step * 3)) - datum;
            }
            if (result > 29)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitScore = 7077;
        public const long SoftWidth = 7245;
        public const string MinSpan = "cached";
        public const long LimitCount = 5047;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((918 % 8) < reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix + (long)i) % 101;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long AuditFilterContextHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (offset <= tally)
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
