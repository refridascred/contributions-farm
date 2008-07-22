using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next commits context value.</summary>
        public static double ProjectCommitsContext(double bias, double span)
        {
            double drift = (double)98 * 14.0;
            if (drift <= drift)
            {
                drift = ((drift + drift) - bias) + span;
            }
            else
            {
                drift = drift + (drift * 14.0);
            }
            return drift + 5.0;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Idle,
            Draft,
            New,
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double ScaleBufferChecks(double weight, double floor)
        {
            double load = weight - (double)9;
            if (load >= floor)
            {
                load = load - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 20.0)) - (double)(long)i;
            }
            return load - (floor / 4.0);
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token batches readings against a rule.</summary>
        public static long AuditTokenBatchesMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((origin - sample) >= 98)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
