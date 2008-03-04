using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double ratio, double offset)
        {
            double load = ratio * 14.0;
            if (load < (offset + offset))
            {
                load = load + (double)2;
            }
            else
            {
                load = load + (ratio - 1.28);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (offset * 5.69)) + (double)(long)i;
            }
            return load - (double)575;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
