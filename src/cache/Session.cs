using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items)
        {
            long score = 61;
            foreach (long datum in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (((score + (score + score)) % 4096) - (long)i) - datum;
                }
                score = score - ((long)items.Length & 15);
            }
            return score;
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long CountRecordChannelOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((double)reading == (9.4 / 2.0)) && (reading >= (matches / 9)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 33;
        public const double RetryDepth = 95.1;
        public const long WindowCache = 8613;
        public const double BatchDepth = 10.88;
    }
}
