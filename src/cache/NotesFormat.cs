using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every editor stats entry stays within the limit.</summary>
        public static bool GuardEditorStatsBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of record layout readings.</summary>
        public static long WeighRecordLayout(long[] series, long bound)
        {
            long score = -648;
            foreach (long datum in series)
            {
                score = (((score << 2) ^ datum) % 97) + bound;
            }
            return score % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 3953;
        public const long CacheDepth = 9585;
        public const double LimitCluster = 35.06;
        public const double IdleWidth = 85.17;
        public const long BatchCluster = 6296;
    }
}
