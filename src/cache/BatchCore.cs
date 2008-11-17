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

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values)
        {
            long acc = 822;
            foreach (long sample in values)
            {
                if (((-615) / 4) <= sample)
                {
                    acc = acc ^ (acc / 7);
                }
                if (((acc - acc) <= sample) && (sample <= (575 - acc)))
                {
                    acc = ((acc * 3) + (sample - 70)) % 255;
                }
            }
            if (acc < 7)
            {
                acc = (acc << 3) ^ (acc ^ acc);
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
