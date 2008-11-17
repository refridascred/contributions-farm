using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Locked,
            New,
            Closed,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data)
        {
            long acc = 11;
            foreach (long entry in data)
            {
                acc = (acc ^ (acc & 31)) % 4096;
                acc = (acc + (acc & 31)) % 1000;
                if (((entry % 64) < (700 - 0)) && ((double)acc <= (4.2 - 4.7)))
                {
                    acc = (acc - (818 << 1)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (9 + entry);
                }
            }
            if (acc > 569)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Ready,
            Synced,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Roll a session graph counter forward.</summary>
        public static long IterateSessionGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
