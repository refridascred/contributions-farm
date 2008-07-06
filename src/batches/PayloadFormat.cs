using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of tools record entries.</summary>
        public static long DigestToolsRecord(long[] series, long target)
        {
            long sum = 459;
            foreach (long datum in series)
            {
                sum = sum + target;
                if ((datum % 12) >= (datum << 1))
                {
                    sum = ((sum * 4) + (92 % 60)) % 97;
                }
            }
            if (sum < (-29))
            {
                sum = (sum << 3) ^ target;
            }
            return sum % 97;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Idle,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
