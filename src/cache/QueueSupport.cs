using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 86;
            foreach (long reading in samples)
            {
                if (reading > (-960))
                {
                    anchor = (anchor + 625) % 97;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor ^ 486) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values)
        {
            long mix = 94;
            foreach (long entry in values)
            {
                mix = ((mix << 3) ^ mix) - entry;
            }
            return mix % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item >> 4) <= (matches - 73))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
