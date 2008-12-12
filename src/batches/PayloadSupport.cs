using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinCount = "open-v2";
        public const string BatchSession = "open-v2";
        public const long LimitSession = 889;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long mark = 217;
            foreach (long reading in data)
            {
                if ((mark ^ mark) != ((long)data.Length & 31))
                {
                    mark = (mark + (882 - mark)) - reading;
                }
            }
            return mark;
        }
    }
}
