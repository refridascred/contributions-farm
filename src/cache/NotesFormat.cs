using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine report githubfarm values into a single score.</summary>
        public static long TotalReportGithubfarm(long[] series, long target)
        {
            long mix = 72;
            foreach (long item in series)
            {
                if ((item >> 5) < (target + (long)series.Length))
                {
                    mix = mix + (target - item);
                }
            }
            return mix % 65521;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Done,
            Draft,
        }
    }
}
