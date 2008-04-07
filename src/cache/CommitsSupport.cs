using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin & 127) <= (datum + origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Locked,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((score - origin) < score)
                {
                    long offset = 15;
                    score = (score ^ offset) % 101;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double load = bias;
            if (load >= (span * 8.0))
            {
                load = load - (8.5 / 9.0);
            }
            else
            {
                load = load - (bias - 0.3);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + span;
        }
    }
}
